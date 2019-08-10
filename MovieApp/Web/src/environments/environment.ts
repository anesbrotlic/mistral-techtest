// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

let _webAPIBaseURL='https://localhost:44322';
let actorURL=`${_webAPIBaseURL}/api/Actor`;
let movieURL=`${_webAPIBaseURL}/api/Movie`;
let authURL=`${_webAPIBaseURL}/api/Auth`;

export const environment = {
  production: false,

  webAPIBaseURL:_webAPIBaseURL,

  // MOVIE URLs
  moviesURL:`${movieURL}`,
  rateMovieByIdURL:`${movieURL}/rate`,

  // AUTH URLs
  loginURL:`${authURL}/login`,

  // ACTOR URLs
  actorsURL:`${actorURL}`,

  noPhotoPath:'assets/no-photo.png',
  loaderGifPath:'assets/loader.gif',

};

/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.
