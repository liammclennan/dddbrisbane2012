
function countJsFiles() {
    return getLines().filter(isJsFile).reduce(step, 0);

    function getLines() {
        return [ "one.js", "two.js", "README.txt" ];
    }

    function isJsFile(fileName) {
        return /\.js$/.test(fileName);
    }

    function step(memo, item) {
        return memo + 1;
    }
}

console.log(countJsFiles());