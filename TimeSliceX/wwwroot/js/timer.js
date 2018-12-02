var interval;
var startTime;

var clock = document.getElementById("clock");
var startButton = document.getElementById("startButton");
var currentTime;
var timeLimit = 2000;
var timeDiff = 0;

function showTime(startTime) {
    
    if (timeDiff >= timeLimit) {
        clearInterval(interval);
    }
    else {
        timeDiff = new Date() - startTime;
        currentTime = convertCount(timeDiff);
        clock.innerHTML = currentTime;
    }
}

function startTimer() {
    startTime = new Date();
    interval = setInterval(showTime, 1000, startTime);
}



function convertCount(millis) {
    var minutes = Math.floor(millis / 60000);
    var seconds = ((millis % 60000) / 1000).toFixed(0);
    return minutes + ":" + (seconds < 10 ? '0' : '') + seconds;
}



