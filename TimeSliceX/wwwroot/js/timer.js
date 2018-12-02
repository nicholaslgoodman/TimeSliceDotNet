var interval;
var startTime;

var clock = document.getElementById("clock");
var startButton = document.getElementById("startButton");
var currentTime;
var timeLimit = 20000;
var timeDiff = 0;
var shortBreaks;
var shortBreakTimeLimit;
var shortBreakLimit;
var longBreaks;
var longBreakTimeLimit;
var noTime = '0:00';
var sliceCount = 0;

function showTime(startTime) {
    
    if (timeDiff >= timeLimit) {
        clearInterval(interval);
    }
    else {
        timeDiff = new Date() - startTime;
        currentTime = convertCount(timeDiff);
        clock.innerHTML = currentTime;
        sliceCount += 1;
        countSlices();
    }
}

function startTimer() {
    startTime = new Date();
    interval = setInterval(showTime, 1000, startTime);
}

function stopTimer() {
    clearInterval(interval);
    clock.innerHTML = noTime;
}

function countSlices() {
    if (sliceCount >= 4) {
        stopTimer();
    }

}

function convertCount(millis) {
    var minutes = Math.floor(millis / 60000);
    var seconds = ((millis % 60000) / 1000).toFixed(0);
    return minutes + ":" + (seconds < 10 ? '0' : '') + seconds;
}



