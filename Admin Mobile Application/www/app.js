
angular.module('app', [
   'app.core',
   
   'app.tabs',
   'app.companies',
   'app.account',
   'app.login',
   'app.auth'
   ])

.run(function($ionicPlatform) {
  $ionicPlatform.ready(function() {
     
    if (window.cordova && window.cordova.plugins && window.cordova.plugins.Keyboard) {
      cordova.plugins.Keyboard.hideKeyboardAccessoryBar(true);
      cordova.plugins.Keyboard.disableScroll(true);

    }
    if (window.StatusBar) {
       
      StatusBar.styleDefault();
    }
  });
})

.config(function($stateProvider, $urlRouterProvider) {

  $stateProvider

    .state('tab', {
    url: '/tab',
    abstract: true,
    templateUrl: 'tabs/tabs.html',
    controller: 'TabsController as vm'
  })

  .state('tab.companies', {
      url: '/chats',
      views: {
        'tab-chats': {
          templateUrl: 'companies/companies/companies.html',
          controller: 'CompaniesController as vm'
        }
      }
    })
    
    .state('tab.company-detail', {
      url: '/chats/:id',
      views: {
        'tab-chats': {
          templateUrl: 'companies/company-details/companies-detail.html',
           controller: 'CompanyDetailController as vm'
        }
      }
    })
      . state('tab.login', {
      url: '/login',
      views: {
        'tab-login': {
          templateUrl: 'login/login.html',
          controller: 'LoginController as vm'
        }
      }
      })

  .state('tab.account', {
    url: '/account',
    views: {
      'tab-account': {
        templateUrl: 'account/account.html',
        controller: 'AccountController as vm'
      }
    }
  });

  $urlRouterProvider.otherwise('/tab/chats');

});
