function procces (cmd) {
 
    var command = (function () {
        var txt = '';
        return {
            append: function (newTxt) {
                txt += newTxt;
            },
            removeStart: function (count) {
                txt = txt.slice(count);
            },
            removeEnd: function (count) {
                txt = txt.slice(0, txt.length - count);
            },
            print: function () {
                console.log(txt);
            }
        }
    })();
    for(var com of cmd){
        var [cmdName, arg] = com.split(' ');
        command[cmdName](arg);
    }
}