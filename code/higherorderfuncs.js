module.exports = {

    createAdder: function (increment) {
        return function (input) {
            return increment + input;
        }
    }

};

