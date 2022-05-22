import React, {useState} from "react"
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import Home from "./Home/Home"

function App() {
  const [db, setdb] = useState({})
  return (
    
    <div className="App">
      <Home />    
    </div>
  );
}

export default App;
