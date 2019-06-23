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

    describe('Testing array getColor', () => {

        it('should return array containing ["blue", "red", "white"]', () => {

            const result = sample.getColor();
            expect(result).toEqual(expect.arrayContaining(["blue", "red", "white"]));
        });

        it('should return array contain red', () => {

            const result = sample.getColor();
            expect(result).toContain("red");
        });

        it('should return array contain white', () => {

            const result = sample.getColor();
            expect(result).toContain("white");
        });

        it('should return array contain blue', () => {

            const result = sample.getColor();
            expect(result).toContain("blue");
        });

    });

    describe('Testing objects getColor', () => {

        it('should return product with the given id', () => {

            const result = sample.getProduct(1);
            expect(result).toMatchObject({
                id: 1
            });
        });

        it('should return product with the given id', () => {

            const result = sample.getProduct(1);
            expect(result).toHaveProperty('id', 1);
        });

    });

    describe('Testing Exception', () => {
        //NULL, underfined, NaN, '', 0 , false
        it('should return exception if input is falsy', () => {

            const args = [null, NaN, '', 0, false];
            args.forEach(x => {
                expect(() => sample.getException(x)).toThrow();
            })
            expect(() => sample.getException(underfined)).toThrow();
        });

        it('should return exception if input is falsy', () => {

            expect(() => sample.getException(null)).toThrow();
            expect(() => sample.getException(underfined)).toThrow();
            expect(() => sample.getException('')).toThrow();
            expect(() => sample.getException(0)).toThrow();
            expect(() => sample.getException(NaN)).toThrow();
            expect(() => sample.getException(false)).toThrow();
        });

        it('should "xing" exception if input is "xing"', () => {
            const result = sample.getException("xing");
            expect(result).toMatchObject({
                username: 'xing'
            });
            expect(result).toBeGreaterThan(0);
        });
    });
});