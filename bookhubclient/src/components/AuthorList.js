import React, { useContext, useEffect } from 'react';
import { AppContext } from '../context/AppContext';
import HttpClientService from '../services/HttpClientService';
import { RequestParameters } from '../models/RequestParameters';

const AuthorList = () => {
    const { baseUrl } = useContext(AppContext);

    useEffect(() => {
        const fetchData = async () => {
            const requestParameters = new RequestParameters('Authors', null, {}, baseUrl);
            try {
                const data = await HttpClientService.get(requestParameters);
                console.log(data);
            } catch (error) {
                console.error('Error fetching data:', error);
            }
        };

        fetchData();
    }, [baseUrl]);

    return <div>Author List Component</div>;
};

export default AuthorList;
