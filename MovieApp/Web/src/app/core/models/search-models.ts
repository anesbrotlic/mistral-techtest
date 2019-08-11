import { SearchTypeEnum, KeywordTypeEnum } from '../enums/search-enums';

export class SearchModel{
    
    regularSearch:boolean;
    keywordSearchObject:KeywordSearchModel;
    value:string;

}
export class KeywordSearchModel{

    searchType: SearchTypeEnum;
    keyWordType: KeywordTypeEnum;

}

