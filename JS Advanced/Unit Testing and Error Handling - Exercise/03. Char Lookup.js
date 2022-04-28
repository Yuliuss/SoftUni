let charLook= require("../charLookup").lookupChar;
let expect = require("chai").expect;
 
describe("lookupChar(string,index) ", function() {
    it("with non-string first parameter should return undefined ", function () {
        let test = charLook(1,9);
        expect(test).to.be.equal(undefined);
    });
        it("with non-number first parameter should return undefined", function () {
            let test = charLook("pers","ghgh");
            expect(test).to.be.equal(undefined);
        });
    it("with floating point number second parameter should return undefined", function () {
        let test = charLook("pers",1.4);
        expect(test).to.be.equal(undefined);
    });
    it("if string lenght is < index should return Incorrect index ", function () {
        let test = charLook('hj',6);
        expect(test).to.be.equal('Incorrect index');
    });
    it("if index is < 0 should return Incorrect index", function () {
        let test = charLook("asdkjl",-3);
        expect(test).to.be.equal("Incorrect index");
    });
    it("with correct parametres should return correct value ", function () {
        let test = charLook("asdhlk",3);
        expect(test).to.be.equal("h");
    });
    it("with correct parametres should return correct value", function () {
        let test = charLook("asdhlk",2);
        expect(test).to.be.equal("d");
    });
});