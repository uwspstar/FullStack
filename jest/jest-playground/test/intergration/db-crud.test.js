const {
    dbConnInit,
    dbClose
} = require('../../db-crud');

beforeAll(() => dbConnInit());
afterAll(() => dbClose());

// beforeEach(() => dbConnInit());
// afterEach(() => dbClose());

describe('', () => {

    it('create', () => {
        // expect(1).toBe(2);
    });
    it('read', () => {

    });
    it('update', () => {

    });
    it('delete', () => {

    });
});