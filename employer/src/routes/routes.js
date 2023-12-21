import { BrowserRouter as Router, Route, Routes, Link } from "react-router-dom";
import { useState, useEffect } from 'react';

import App from "../features/App";
import LoginPage from "../features/Login";

const NavRoute = () => {

    const [loggedIn, setLoggedIn] = useState(false);

    useEffect(() => {
        const user = localStorage.getItem("Logged");
        if(user) {
            setLoggedIn(true);
        }
    }, []);

    return (
        <Router>
            <nav className="bg-dark h-5" style={{ height: '40px' }}>
                <div className="container">
                    <div className="d-flex gap-3 h-100">
                        <li className="nav-item h-100">
                            <Link to="/"> HOME </Link>
                        </li>
                        <li className="nav-item h-100">
                            { 
                                loggedIn ? (
                                    <button onClick={() => handleLogOut(setLoggedIn)}>LOGOUT</button>
                                ) : (
                                    <Link to="/login">LOGIN</Link>
                                )
                            }
                        </li>
                    </div>
                </div>
            </nav>

            <Routes>
                <Route path="/" element={<App loggedIn={loggedIn} setLoggedIn={setLoggedIn} />} />
                <Route path="/login" element={<LoginPage setLoggedIn={setLoggedIn} />} />
            </Routes>
        </Router>
    );
};

const handleLogOut = (setLoggedIn) => {
    localStorage.removeItem("Logged");
    setLoggedIn(false);
};

export default NavRoute;