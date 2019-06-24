const testApi = require('../../api');
describe('Testing API', () => {
    describe('Testing promis', () => {
        it('should return username: Bret when input id is 1', () => {
            expect.assertions(1);
            return testApi.fetchUser()
                .then(data => {
                    expect(data.username).toBe("Bret");
                });
        });
        it('should return id: 1 user when input id is 1', () => {
            expect.assertions(1);
            return testApi.fetchUser()
                .then(data => {
                    expect(data.id).toEqual(1);
                });
        });
        it('should return object match id:1 when input id is 1', () => {
            expect.assertions(1);
            return testApi.fetchUser()
                .then(data => {
                    expect(data).toMatchObject({
                        id: 1
                    });
                });
        });
    });

    describe('Testing async await', () => {
        it('should return username: Bret when input id is 1', async () => {
            expect.assertions(1);
            const data = await testApi.fetchUser();
            expect(data.username).toBe("Bret");
        });

        it('should return id: 1 user when input id is 1', async () => {
            expect.assertions(1);
            const data = await testApi.fetchUser();
            expect(data.id).toEqual(1);
        });

        it('should return object match id:1 when input id is 1', async () => {
            expect.assertions(1);
            const data = await testApi.fetchUser();
            expect(data).toMatchObject({
                id: 1
            });
        });
    });
});