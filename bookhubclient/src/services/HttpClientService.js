import axios from 'axios';

class HttpClientService {
    url(requestParameters) {
        return `${requestParameters.baseUrl || ''}/${requestParameters.controller}${requestParameters.action ? `/${requestParameters.action}` : ''}`;
    }

    async get(requestParameters, id = '') {
        const url = requestParameters.fullEndPoint || `${this.url(requestParameters)}${id ? `/${id}` : ''}`;
        console.log('GET Request URL:', url);
        try {
            const response = await axios.get(url, { headers: requestParameters.headers });
            return response.data;
        } catch (error) {
            console.error('GET request error:', error);
            throw error;
        }
    }

    async post(requestParameters, body) {
        const url = requestParameters.fullEndPoint || this.url(requestParameters);
        console.log('POST Request URL:', url);
        console.log('POST Request Body:', body);

        try {
            const response = await axios.post(url, body, { headers: requestParameters.headers });
            return response.data;
        } catch (error) {
            console.error('POST request error:', error);
            throw error;
        }
    }

    async put(requestParameters, body) {
        const url = requestParameters.fullEndPoint || this.url(requestParameters);
        console.log('PUT Request URL:', url);
        console.log('PUT Request Body:', body);

        try {
            const response = await axios.put(url, body, { headers: requestParameters.headers });
            return response.data;
        } catch (error) {
            console.error('PUT request error:', error);
            throw error;
        }
    }

    async delete(requestParameters, id) {
        const url = requestParameters.fullEndPoint || `${this.url(requestParameters)}/${id}`;
        console.log('DELETE Request URL:', url);

        try {
            const response = await axios.delete(url, { headers: requestParameters.headers });
            return response.data;
        } catch (error) {
            console.error('DELETE request error:', error);
            throw error;
        }
    }
}

export default new HttpClientService();
