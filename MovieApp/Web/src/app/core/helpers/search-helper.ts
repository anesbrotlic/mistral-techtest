import { AppConstants } from '../common/app.constants';
import { SearchTypeEnum, KeywordTypeEnum } from '../enums/search-enums';
import { SearchModel } from '../models/search-models';

export class SearchHelper {

    private static regex: RegExp;

    static isContainingNumber(value: string): boolean {

        this.regex = new RegExp("\\b\\d+\\b");
        return this.regex.test(value);

    }

    static getNumberFromString(value: string) {
        this.regex = new RegExp("\\b\\d+\\b");
        return value.match(this.regex)[0];
    }

    static getCuttedString(source: string, ...values: Array<string>): string {

        values.forEach(v => {

            var regex = new RegExp("\\b" + v + "\\b");
            source = source.replace(regex, '');

        });

        return source;

    }


    static getSearchTypeWordIfExists(value: string, searchTypeEnum: SearchTypeEnum): string {

        if (searchTypeEnum == SearchTypeEnum.Rating)
            return this.getMatchedKeyword(value, AppConstants.rating_search_type_keywords);
        if (searchTypeEnum == SearchTypeEnum.ReleaseDate)
            return this.getMatchedKeyword(value, AppConstants.release_search_type_keywords);

    }

    static getKeywordTypeWordIfExists(value: string, searchTypeEnum: SearchTypeEnum) {

        if (searchTypeEnum == SearchTypeEnum.Rating)
            return this.getMatchedKeyword(value, AppConstants.rating_keyword_type_all_keywords);
        if (searchTypeEnum == SearchTypeEnum.ReleaseDate)
            return this.getMatchedKeyword(value, AppConstants.release_keyword_type_all_keywords);
    }


    private static getMatchedKeyword(value: string, keywordsArray: Array<string>) {

        let keyword: string = null;

        try {
            keywordsArray.forEach(k => {

                this.regex = new RegExp("\\b" + k + "\\b");

                if (value.match(this.regex)) {
                    keyword = k;
                    throw Error;
                }
            });
        } catch (error) {
        }

        return keyword;
    }

    private static isNumberYear(value: number) {
        return value > 1887 && value < ((new Date()).getFullYear() + 1);
    }



    static tryGetSearchModel_rating(value: string): SearchModel {

        let keywordTypeWord = this.getKeywordTypeWordIfExists(value, SearchTypeEnum.Rating);
        let searchTypeKeyWord = this.getSearchTypeWordIfExists(value, SearchTypeEnum.Rating);
        let numberFromValue = this.getNumberFromString(value);

        // CHECK IF SEARCH STRING CONTAINS MORE ELEMENT THAN NEEDED; 
        // IF SO DON'T SEARCH ==> return null;
        let cuttedValue = this.getCuttedString(value, numberFromValue, searchTypeKeyWord, keywordTypeWord);
        if (cuttedValue.replace(/\s/g, '').length > 0)
            return null;

        let searchObjet: SearchModel = {
            regularSearch: false,
            value: numberFromValue,
            keywordSearchObject: {
                searchType: SearchTypeEnum.Rating,
                keyWordType: null
            }
        };


        // LET'S FIND OUT KeywordType
        let keywordSrchType: KeywordTypeEnum;

        // more
        if (AppConstants.rating_more_kw.includes(keywordTypeWord))
            keywordSrchType = KeywordTypeEnum.More;
        //   less
        else if (AppConstants.rating_less_kw.includes(keywordTypeWord))
            keywordSrchType = KeywordTypeEnum.Less;
        //   at least
        else if (AppConstants.rating_at_least_kw.includes(keywordTypeWord))
            keywordSrchType = KeywordTypeEnum.AtLeast;
        //   at most
        else if (AppConstants.rating_at_most_kw.includes(keywordTypeWord))
            keywordSrchType = KeywordTypeEnum.AtMost;
        //   exact
        else
            keywordSrchType = KeywordTypeEnum.Exact;

        searchObjet.keywordSearchObject.keyWordType = keywordSrchType;

        return searchObjet;
    }

    static tryGetSearchModel_release(value: string): SearchModel {

        let keywordTypeWord = this.getKeywordTypeWordIfExists(value, SearchTypeEnum.ReleaseDate);
        let searchTypeKeyWord = this.getSearchTypeWordIfExists(value, SearchTypeEnum.ReleaseDate);
        let numberFromValue = this.getNumberFromString(value);

        // CHECK IF SEARCH STRING CONTAINS MORE ELEMENT THAN NEEDED; 
        // IF SO DON'T SEARCH ==> return null;
        let cuttedValue = this.getCuttedString(value, numberFromValue, searchTypeKeyWord, keywordTypeWord);
        if (cuttedValue.replace(/\s/g, '').length > 0)
            return null;

        let searchObjet: SearchModel = {
            regularSearch: false,
            value: null,
            keywordSearchObject: {
                searchType: SearchTypeEnum.ReleaseDate,
                keyWordType: null
            }
        };


        // LET'S FIND OUT KeywordType AND CHECK NUMBER value (5,2012,3,2018)
        let keywordSrchType: KeywordTypeEnum;

        // before
        if (AppConstants.release_before_kw.includes(keywordTypeWord)) {

            if (!this.isNumberYear(+numberFromValue))
                return null;

            keywordSrchType = KeywordTypeEnum.Less;

        }
        //   after
        else if (AppConstants.release_after_kw.includes(keywordTypeWord)) {

            if (!this.isNumberYear(+numberFromValue))
                return null;

            keywordSrchType = KeywordTypeEnum.More;

        }
        //   at least
        else if (AppConstants.release_at_least_kw.includes(keywordTypeWord)) {

            if (!this.isNumberYear(+numberFromValue))
                return null;

            keywordSrchType = KeywordTypeEnum.AtLeast;

        }
        //   at most
        else if (AppConstants.release_at_most_kw.includes(keywordTypeWord)) {

            if (!this.isNumberYear(+numberFromValue))
                return null;

            keywordSrchType = KeywordTypeEnum.AtMost;

        }
        //   older than
        else if (AppConstants.release_older_kw.includes(keywordTypeWord)) {

            if (!this.isNumberYear(+numberFromValue))
                numberFromValue = ((new Date().getFullYear()) - (+numberFromValue)).toString();

            keywordSrchType = KeywordTypeEnum.Less;

        }
        //   exact
        else
            keywordSrchType = KeywordTypeEnum.Exact;


        // SET MISSING VALUES TO SearchObject
        searchObjet.value = numberFromValue;
        searchObjet.keywordSearchObject.keyWordType = keywordSrchType;

        return searchObjet;


    }


}