'use strict';
function solve(){
function checkIfBrowserIsMozilla(ev, args) {
  var myWindow = window,
      browser = myWindow.navigator.appCodeName,
      isMozilla = (browser === "Mozilla");
          
    if(isMozilla) {
        alert('Yes');
    } 
    else {
        alert('No');
    }
  }
}