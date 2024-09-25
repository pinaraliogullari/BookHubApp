export class RequestParameters {
    constructor(controller, action, headers = {}, baseUrl, fullEndPoint) {
        this.controller = controller;
        this.action = action;
        this.headers = headers;
        this.baseUrl = baseUrl;
        this.fullEndPoint = fullEndPoint;
    }
}