(function() {
    'use strict';

    angular.module('app.core').config(httpInterceptor).config(ionicConfigProvider);



    ///////////////////////////////////////////////////

    httpInterceptor.$inject = ['$httpProvider'];
    function httpInterceptor($httpProvider) {
        $httpProvider.interceptors.push('authInterceptorService');
        $httpProvider.defaults.headers.post = { 'Content-Type': 'application/json' };
    }

     ionicConfigProvider.$inject = ['$ionicConfigProvider'];
    function ionicConfigProvider($ionicConfigProvider) {
 $ionicConfigProvider.tabs.position('bottom');
    }

})();