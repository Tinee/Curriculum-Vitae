(function () {
   'use strict';

   angular
      .module('app.tabs')
      .controller('TabsController', TabsController);

   TabsController.$inject = [];
   function TabsController() {
      var vm = this;

      vm.loggedIn = false;

      activate();

      function activate() {
         isLoggedIn();
      }

      function isLoggedIn() {
         var authData = JSON.parse(window.localStorage.getItem('token'));

         if (authData) {
            vm.loggedIn = true;
         }
         else {
            vm.loggedIn = false;
         }
      }
   }
})();