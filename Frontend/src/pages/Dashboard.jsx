import { Link } from 'react-router-dom';
import RecordTable from '../components/RecordTable';

const Dashboard = () => {
  return (
    <div className='container'>
      <div className='row min-vh-100'>
        <div className='col d-flex flex-column justify-content-center align-items-center'>
          <div>
            <h1>Records</h1>
            <div className='mt-5'>
              <Link className='btn btn-success btn-lg w-100' to='/add'>
                Create New Record
              </Link>
              <RecordTable />
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};
export default Dashboard;
