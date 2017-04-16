document.getElementById('gameButton1').onclick = function () {
  var child = require('child_process').execFile;
  var executablePath = __dirname + "\\BallPath.exe";

  child(executablePath, function(err, data) {
      if(err){
         console.error(err);
         return;
      }

      console.log(data.toString());
  });
};
document.getElementById('gameButton2').onclick = function () {
  var child = require('child_process').execFile;
  var executablePath = __dirname + "\\SlidingPuzzle.exe";

  child(executablePath, function(err, data) {
      if(err){
         console.error(err);
         return;
      }

      console.log(data.toString());
  });
};
 document.getElementById('gameButton3').onclick = function () {
   var child = require('child_process').execFile;
   var executablePath = __dirname + "\\ShapeToss.exe";

   child(executablePath, function(err, data) {
       if(err){
          console.error(err);
          return;
       }

       console.log(data.toString());
   });
 };
document.getElementById('gameButton4').onclick = function () {
  var child = require('child_process').execFile;
  var executablePath = __dirname + "\\FightClub.exe";

  child(executablePath, function(err, data) {
      if(err){
         console.error(err);
         return;
      }

      console.log(data.toString());
  });
};
