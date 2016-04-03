

(function() {
   'use strict';

   angular
      .module('factories.module')
      .factory('levelbar', Levelbar);

   Levelbar.$inject = [];
   function Levelbar() {
      var service = {
         levelbar: levelbar()
      };

      return service;

      ////////////////
      function levelbar() {
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

