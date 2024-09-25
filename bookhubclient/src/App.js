import React from 'react';
import { AppProvider } from './context/AppContext';
import AuthorList from './components/AuthorList';

const App = () => {
  return (
    <AppProvider>
      <AuthorList />
    </AppProvider>
  );
};

export default App;
