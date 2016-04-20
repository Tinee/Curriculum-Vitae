




(function () {
   'use strict';

   angular
      .module('app.auth')
      .factory('authService', AuthService);

   AuthService.$inject = ['$location', '$http', '$q', '$state'];
   function AuthService($location, $http, $q, $state) {


      var serviceBase = 'http://localhost:2911/';
      var authServiceFactory = {};

      var _authentication = {
         isAuth: false,
         user: {}
      };


      var _login = function (loginData) {

         var data = "grant_type=password&username=" + loginData.userName + "&password=" + loginData.password;

         var deferred = $q.defer();

         $http.post(serviceBase + 'token', data, { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } }).success(function (response) {

            window.localStorage.setItem('token', angular.toJson({ token: response.access_token }));

            _authentication.isAuth = true;
               _authentication.userName = loginData.userName;

            $location.path('/tab/companies');
            window.location.reload();

            deferred.resolve(response);

         }).error(function (err, status) {
            deferred.reject(err);
         });

         return deferred.promise;
      };

      var _logOut = function () {

         localStorageService.remove('authUser');

         _authentication.isAuth = false;
         _authentication.userName = "";

      };

      var _fillAuthData = function () {

         var authData = localStorageService.get('authorizationData');
         if (authData) {
            _authentication.isAuth = true;
            _authentication.user = authData.user;
         }

      };

      authServiceFactory.login = _login;

      authServiceFactory.authentication = _authentication;

      return authServiceFactory;


   }
})();