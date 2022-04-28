describe("isOddOrEven", () => {
    it("Should return undefined with invalid argument", () => {
        assert.equal(undefined, evenOrNot(5));
        assert.equal(undefined, evenOrNot(true));
    });
 
    it("Should return correct result with valid argument - even length", () => {
        assert.equal("even", evenOrNot("toto"));
    });
 
    it("Should return correct result with valid argument - odd length", () => {
        assert.equal("odd", evenOrNot("tot"));
    });
 
    it("Should return correct result with valid arguments", () => {
        assert.equal("odd", evenOrNot("tests"));
        assert.equal("even", evenOrNot("some"));
    });
});