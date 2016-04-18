(function() {
    'use strict';

    angular.module('app.core').config(httpInterceptor);

    ///////////////////////////////////////////////////

    httpInterceptor.$inject = ['$httpProvider'];
    function httpInterceptor($httpProvider) {
        $httpProvider.interceptors.push('authInterceptorService');
        $httpProvider.defaults.headers.post = { 'Content-Type': 'application/json' };
    }

})();