(function() {
   'use strict';

   angular.module('app', [
      'app.core',

      'layout.module',
      'factories.module',
      'directives.module'
   ]).config([
      '$stateProvider',
       '$locationProvider',
       '$urlRouterProvider',
       Routes]);
})();

function Routes($stateProvider, $locationProvider, $urlRouterProvider) {
    $urlRouterProvider.otherwise('/');

    $stateProvider
        .state('dashboard', {
        url: '/',
        controller: 'LayoutController as vm',
        templateUrl: '/app/layout/layout.html',
    });

    $locationProvider.html5Mode(true);
}