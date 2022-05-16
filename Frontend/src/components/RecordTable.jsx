import { useState, useEffect } from 'react';
import { Link, useNavigate } from 'react-router-dom';
import Constants from '../utils/Constants';

const RecordTable = () => {
  const [records, setRecords] = useState([]);

  const navigate = useNavigate();
  useEffect(() => {
    getAllRecords();
  }, [navigate]);

  const getAllRecords = () => {
    const url = Constants.GET_ALL_RECORDS;

    fetch(url, {
      method: 'GET',
    })
      .then((response) => response.json())
      .then((recordsFromServer) => {
        setRecords(recordsFromServer);
      })
      .catch((err) => {
        console.log(err);
        alert(err);
      });
  };

  if (records.length === 0)
    return <h1 className='mt-5'>No Records Created Yet.</h1>;

  return (
    <div className='table-responsive mt-5'>
      <table className='table table-bordered text-center'>
        <thead>
          <tr>
            <th scope='col'>Record Id</th>
            <th scope='col'>Title</th>
            <th scope='col'>Body</th>
            <th scope='col'>Details</th>
          </tr>
        </thead>
        <tbody>
          {records.map((record) => (
            <tr key={record.id}>
              <td>{record.id}</td>
              <td>{record.title}</td>
              <td>{record.body}</td>
              <td><Link to={`details/${record.id}`} className='btn btn-success btn-lg w-100'>Details</Link></td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};
export default RecordTable;
