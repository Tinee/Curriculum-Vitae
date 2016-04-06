

(function() {
   'use strict';

   angular
      .module('factories.module')
      .factory('levelbar', Levelbar);

   Levelbar.$inject = [];
   function Levelbar() {
      var service = {
         getValues: getValues
      };

      return service;

      ////////////////
      function getValues() {
         $('.level-bar-inner').css('width', '0');

         $('.level-bar-inner').each(function() {

            var itemWidth = $(this).data('level');

            $(this).animate({
               width: itemWidth
            }, 800);
         });
      }
   }
})();

