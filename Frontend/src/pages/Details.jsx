import { useState, useEffect } from 'react';
import { useParams, Link } from 'react-router-dom';
import Constants from '../utils/Constants';

const Details = () => {
  const [title, setTitle] = useState('');
  const [body, setBody] = useState('');

  const { id } = useParams();

  useEffect(() => {
    getRecordById();
  }, []);

  const getRecordById = () => {
    const url = `${Constants.GET_RECORD_BY_ID}/${id}`;

    fetch(url, {
      method: 'GET',
    })
      .then((response) => response.json())
      .then((responseFromServer) => {
        console.log(responseFromServer);
        setTitle(responseFromServer.title);
        setBody(responseFromServer.body);
      })
      .catch((err) => {
        console.log(err);
        alert(err);
      });
  };
  return (
    <div className='row min-vh-100'>
      <div className='col d-flex flex-column justify-content-center align-items-center'>
        <h1>{title}</h1>
        <p className='m-5 h3'>{body}</p>
        <Link to={'/'} className='btn btn-success btn-lg w-100'>
          Go Back
        </Link>
      </div>
    </div>
  );
};
export default Details;
