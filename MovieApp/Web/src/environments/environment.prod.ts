let _webAPIBaseURL = 'http://localhost:44322';
let actorURL = `${_webAPIBaseURL}/api/Actor`;
let movieURL = `${_webAPIBaseURL}/api/Movie`;
let authURL = `${_webAPIBaseURL}/api/Auth`;

export const environment = {
  production: true,

  webAPIBaseURL: _webAPIBaseURL,

  // MOVIE URLs
  moviesURL: `${movieURL}`,
  rateMovieByIdURL: `${movieURL}/rate`,

  // AUTH URLs
  loginURL: `${authURL}/login`,

  // ACTOR URLs
  actorsURL: `${actorURL}`,

  noPhotoPath: 'assets/no-photo.png',
  loaderGifPath: 'assets/loader.gif',

};
