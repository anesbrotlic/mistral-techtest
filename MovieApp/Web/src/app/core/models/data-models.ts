import { SearchModel } from './search-models';

export class MovieModel{
    id:number;
    title:string;
    coverImgPath:string;
    description:string;
    releaseDate:string;
    tvShow:boolean;
    actors:string;
    avgRating:number;
    ratingByUser:number;
}

export class ActorModel{
    id:number;
    name:string;
    profileImgPath:string;
}

export class MovieDetailsModel{
    title:string;
    coverImgPath:string;
    description:string;
    releaseDate:string;
    tvShow:boolean;
    avgRating:number;
    ratingByUser:number;
    actors:Array<ActorModel>;
}

export class LoginModel{
    username:string;
    password:string;
}

export class MovieModel2{
    id:number;
    title:string;
    releaseDate:string;
}

export class ActorDetailModel{
    name:string;
    profileImgPath:string;
    moviesOfActor:Array<MovieModel2>;
}

export class MovieRequestModel{
    page:number;
    tvShow:boolean;
    searchObject:SearchModel;
}
