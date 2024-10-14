import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import { useContext } from 'react';
import HttpClientService from '../services/HttpClientService';
import { AppContext } from '../context/AppContext';

const Login = () => {
    const [usernameOrEmail, setUsernameOrEmail] = useState('');
    const [password, setPassword] = useState('');
    const [error, setError] = useState('');
    const navigate = useNavigate();
    const { baseUrl } = useContext(AppContext)

    const handleLogin = async (e) => {
        e.preventDefault();

        const requestParameters = {
            baseUrl: baseUrl,
            controller: 'Users',
            action: 'Login',
            headers: {
                'Content-Type': 'application/json'
            }
        };
        const payload = {
            usernameOrEmail,
            password
        };

        try {
            const response = await HttpClientService.post(requestParameters, payload);
            if (response?.token) {
                const tokenData = {
                    accessToken: response.token.accessToken,
                    expiration: response.token.expiration
                };
                localStorage.setItem('token', JSON.stringify(tokenData));
                navigate('/'); //returnUrl part will add!!!!!!!!!!!!
            } else {
                console.error("Token alınamadı:", response);
            }

        } catch (error) {
            setError('An error occured. Please check your information.');
        }
    };

    return (
        <div>
            <h2>Login</h2>
            <form onSubmit={handleLogin}>
                <div>
                    <label>Email or Username:</label>
                    <input
                        type="text"
                        value={usernameOrEmail}
                        onChange={(e) => setUsernameOrEmail(e.target.value)}
                        required
                    />
                </div>
                <div>
                    <label>Password:</label>
                    <input
                        type="password"
                        value={password}
                        onChange={(e) => setPassword(e.target.value)}
                        required
                    />
                </div>
                <button type="submit">Login</button>
            </form>
            {error && <p style={{ color: 'red' }}>{error}</p>}
        </div>
    );
};

export default Login;
