(function () {
   'use strict';

   angular
      .module('app.login')
      .controller('LoginController', LoginController);

   LoginController.$inject = ['authService'];
   function LoginController(authService) {
      var vm = this;

      vm.loginForm = {
         userName: "",
         password: ""
      };

      vm.login = function () {
         
         authService.login(vm.loginForm).then(function (response) {
         },
            function (err) {
               vm.message = err.error_description;
            });
      };
      activate();

      ////////////////

      function activate() { }
   }
})();