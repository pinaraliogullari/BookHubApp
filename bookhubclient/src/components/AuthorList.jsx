import React, { useEffect, useState, useContext } from 'react';
import { AppContext } from '../context/AppContext';
import HttpClientService from '../services/HttpClientService';
import { GetAllAuthorsResponse } from '../models/GetAllAuthorsResponse';
import { Author } from '../models/Author';


const AuthorList = () => {
    const { baseUrl } = useContext(AppContext)
    const [authors, setAuthors] = useState([]);
    const [totalCount, setTotalCount] = useState(0);

    useEffect(() => {
        const fetchAuthors = async () => {
            const requestParameters = {
                controller: 'authors',
                baseUrl: baseUrl
            };
            try {
                const response = await HttpClientService.get(requestParameters);
                const getAllAuthorsResponse = new GetAllAuthorsResponse(response.totalCount, response.authors);


                const authorsData = getAllAuthorsResponse.authors.map(item => new Author(item.firstName, item.lastName));

                setAuthors(authorsData);
                setTotalCount(getAllAuthorsResponse.totalCount)
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
                    <li key={`${author.firstName}-${author.lastName}-${index}`}>
                        {author.firstName} {author.lastName}
                    </li>
                ))}
            </ul>
        </div>
    );
};

export default AuthorList;
