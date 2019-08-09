export class MovieModel{
    id:number;
    title:string;
    coverImgPath:string;
    description:string;
    releaseDate:string;
    tvShow:boolean;
    actors:string;
    avgRate:number;
    rateByUser:number;
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
    avgRate:number;
    rateByUser:number;
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
