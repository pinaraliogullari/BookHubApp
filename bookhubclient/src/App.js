import React from 'react';
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import { AppContext } from './context/AppContext';
import Home from './components/Home';
import AuthorList from './components/AuthorList';

const App = () => {
  const baseUrl = 'https://localhost:7158/api';
  return (
    <AppContext.Provider value={{ baseUrl }}>
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Home />} />
          <Route path="/author" element={<AuthorList />} />
        </Routes>
      </BrowserRouter>
    </AppContext.Provider>
  );
};

export default App;
