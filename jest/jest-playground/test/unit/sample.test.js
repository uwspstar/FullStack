const sample = require('../../sample');

describe('Testing Samples', () => {

    describe('Testing Absoulte numbers', () => {

        it('should return the positive number if the input is positive', () => {

            const result = sample.getAbsNumber(1);
            expect(result).toBe(1);
        });

        it('should return the positive number if the input is negative', () => {

            const result = sample.getAbsNumber(-1);
            expect(result).toBe(1);
        });

        it('should return the 0 if the input is 0', () => {

            const result = sample.getAbsNumber(0);
            expect(result).toBe(0);
        });
    });

    describe('Testing reverst string', () => {

        it('should return revers string cba if input is abc', () => {

            const result = sample.reversString("abc");
            expect(result).toBe("cba");
        });

        it('should return revers string a if input is a', () => {

            const result = sample.reversString("a");
            expect(result).toBe("a");
        });

        it('should return empty string  if input is empty', () => {
            const result = sample.reversString("");
            expect(result).toBe("");
        });
    });



});