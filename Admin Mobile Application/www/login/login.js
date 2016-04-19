(function() {
    'use strict';

    angular
        .module('app.login')
        .controller('LoginController', LoginController);

    LoginController.$inject = ['authService'];
    function LoginController(authService) {
        var vm = this;

        vm.message = "";
        vm.loginForm = {
            userName: "",
            password: ""
        };


        vm.login = function() {

            authService.login(vm.loginForm).then(function(response) {
            },
                function(err) {
                    vm.message = 'Fel vid inloggning, försök igen.'
                });
        };
        activate();

        ////////////////

        function activate() { }
    }
})();