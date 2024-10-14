import React from 'react';
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import { AppContext } from './context/AppContext';
import Home from './components/Home';
import Login from './pages/Login';
import AuthorList from './components/AuthorList';
import PrivateRoute from './guard/PrivateRoute';

const App = () => {
  const baseUrl = 'https://localhost:7158/api';
  return (
    <AppContext.Provider value={{ baseUrl }}>
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/author" element={<PrivateRoute><AuthorList /></PrivateRoute>} />
          <Route path="/login" element={<Login />} />
        </Routes>
      </BrowserRouter>
    </AppContext.Provider>
  );
};

export default App;
