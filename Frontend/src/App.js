import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Dashboard from './pages/Dashboard';
import AddRecord from './pages/AddRecord';
import Details from './pages/Details';

export default function App() {
  return (
    <>
      <Router>
        <div className='container'>
          <Routes>
            <Route path='/' element={<Dashboard />} />
            <Route path='/add' element={<AddRecord />} />
            <Route path='/details/:id' element={<Details/>} />
          </Routes>
        </div>
      </Router>
    </>
  );
}
