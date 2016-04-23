(function() {
'use strict';

   angular
      .module('app.factories')
      .factory('refreshFactory', refreshFactory);

   refreshFactory.$inject = [];
   function refreshFactory() {
      var service = {
         refresh:refresh
      };
      
      
      //Fixing this later on.
      return service;

      ////////////////
      function refresh() { }
   }
})();