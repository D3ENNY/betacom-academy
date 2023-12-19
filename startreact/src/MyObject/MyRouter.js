import { BrowserRouter as Router, Route, Routes, Link } from "react-router-dom";

import First from "./First";
import App from "../App"

const MyMenu = () => {
    return (
        <Router>

            <li>
                <Link to="/">HOME</Link>
            </li>
            <li>
                <Link to="/first">first</Link>
            </li>
            <li>
                <Link to="/firstmulti">firstmulti</Link>
            </li>

            <Routes>
                <Route path="/" element={<App />} />
                <Route path="/first" element={<First />} />
                <Route path="/multi" element={<prodotto numero={{ a:5, b:7 }} />} />
            </Routes>

        </Router>

    )
}

export default MyMenu