import { BrowserRouter as Router, Route, Routes, Link } from "react-router-dom";
import { useState } from 'react';

import App from "../features/App";
import LoginPage from "../features/Login";


const NavRoute = () => {

    const [loggedIn, setLoggedIn] = useState(false)

    const [email, setEmail] = useState("")

  return (
    <Router>
        <nav className="bg-dark h-5" style={{ height: '40px' }}>
            <div className="container">
                <div className="d-flex gap-3 h-100">
                    <li className="nav-item h-100">
                        <Link to="/"> HOME </Link>
                    </li>
                    <li className="nav-item h-100">
                        <Link to="/login"> LOGIN </Link>
                    </li>
                </div>
            </div>
        </nav>

        <Routes>
            <Route path="/" element={<App email={email} loggedIn={loggedIn} setLoggedIn={setLoggedIn} />} />
            <Route path="/login" element={<LoginPage setLoggedIn={setLoggedIn} setEmail={setEmail} />} />
        </Routes>
    </Router>
  )
}

export default NavRoute;
