const fetch = require('node-fetch');

module.exports = async function (req) {

    const username = (req.query.username || (req.body && req.body.username));
    const apiResult = await fetch ("https://api.nationalize.io?name=" + username);
    const jsonResult = await apiResult.json(); 
    
    return jsonResult;        //* Defaults to 200 */
}