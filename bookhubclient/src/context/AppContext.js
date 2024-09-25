// import React, { createContext, useContext } from 'react';

// const AppContext = createContext();

// export const AppProvider = ({ children }) => {
//     const baseUrl = 'https://localhost:7158/api';

//     return (
//         <AppContext.Provider value={{ baseUrl }}>
//             {children}
//         </AppContext.Provider>
//     );
// };

// export const useAppContext = () => {
//     return useContext(AppContext);
// };


import { createContext } from "react";
const AppContext = createContext();
export { AppContext };