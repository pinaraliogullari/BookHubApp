import React, { useEffect, useState, useContext } from 'react';
import { AppContext } from '../context/AppContext';
import HttpClientService from '../services/HttpClientService';
import { Author } from '../models/Author';


const AuthorList = () => {
    const { baseUrl } = useContext(AppContext)
    const [authors, setAuthors] = useState([]);

    useEffect(() => {
        const fetchAuthors = async () => {
            const requestParameters = {
                controller: 'authors',
                baseUrl: baseUrl
            };
            console.log('Request Parameters:', requestParameters);
            try {
                const data = await HttpClientService.get(requestParameters);
                console.log(data);

                const authorsData = data.map(item => new Author(item.firstName, item.lastName));
                setAuthors(authorsData);
            } catch (error) {
                console.error('Error fetching authors:', error);
            }
        };

        fetchAuthors();
    }, [baseUrl]);

    return (
        <div>
            <h2>Author List</h2>
            <ul>
                {authors.map((author, index) => (
                    <li key={`${author.FirsName}-${author.LastName}-${index}`}>
                        {author.FirsName} {author.LastName}
                    </li>
                ))}
            </ul>
        </div>
    );
};

export default AuthorList;
