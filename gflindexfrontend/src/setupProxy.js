const { createProxyMiddleware } = require('http-proxy-middleware');

const context = [
    "/gflindex",
];

module.exports = function (app) {
    const appProxy = createProxyMiddleware(context, {
        target: 'https://localhost:7032',
        secure: false
    });

    app.use(appProxy);
};
