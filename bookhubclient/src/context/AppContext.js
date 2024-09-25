import React, { createContext, useContext } from 'react';

const AppContext = createContext();

export const AppProvider = ({ children }) => {
    const baseUrl = 'https://localhost:7158';

    return (
        <AppContext.Provider value={{ baseUrl }}>
            {children}
        </AppContext.Provider>
    );
};

export const useAppContext = () => {
    return useContext(AppContext);
};

export { AppContext };
