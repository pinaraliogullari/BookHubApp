import React from 'react';
import { Navigate } from 'react-router-dom';
import { jwtDecode } from 'jwt-decode';

function PrivateRoute({ children }) {
    const tokenString = localStorage.getItem('token');
    const token = tokenString ? JSON.parse(tokenString) : null; // JSON'dan nesneye çevir
    console.log('Token:', token); // Token'ı kontrol et

    if (!token || !token.accessToken) { // accessToken kontrolü
        return <Navigate to="/login" />;
    }

    let payload;
    try {
        payload = jwtDecode(token.accessToken); // accessToken'ı çözümle
    } catch (error) {
        console.error('Token çözümleme hatası:', error);
        return <Navigate to="/login" />;
    }

    console.log("Payload:", payload); // Payload'ı kontrol et
    if (!payload || !payload.exp || payload.exp * 1000 < Date.now()) {
        console.log("Token geçersiz veya süresi dolmuş.");
        return <Navigate to="/login" />;
    }

    return children;
}

export default PrivateRoute;
