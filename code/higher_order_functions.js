module.exports = createAdder(increment) {
    return function (input) {
        return increment + input;
    };
}

