(function() {
'use strict';

   angular
      .module('layout.module')
      .controller('LayoutController', LayoutController);

   LayoutController.$inject = ['levelbar'];
   function LayoutController(levelbar) {
      var vm = this;
      

      activate();

      ////////////////

      function activate() {
       }
   }
})();