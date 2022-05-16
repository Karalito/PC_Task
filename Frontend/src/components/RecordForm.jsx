import { useState } from 'react';
import { Link, useNavigate } from 'react-router-dom';
import Constants from '../utils/Constants';

const RecordForm = () => {
  const [title, setTitle] = useState('');
  const [body, setBody] = useState('');

  const navigate = useNavigate();

  const handleSubmit = (e) => {
    e.preventDefault();

    const newRecord = {
      title: title,
      body: body,
    };
    console.log(newRecord);
    const url = Constants.CREATE_RECORD;
    console.log(url);
    fetch(url, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
        Accept: 'application/json',
      },
      body: JSON.stringify(newRecord),
    })
      .then((response) => response.json())
      .then((responseFromServer) => console.log(responseFromServer))
      .catch((err) => {
        console.log(err);
        alert(err);
      });

    navigate('/');
  };

  return (
    <div>
      <form className='w-100 px-5' onSubmit={handleSubmit}>
        <h1 className='mt-5'>Create Record</h1>
        <div className='mt-5'>
          <label className='form-label h3'>Record Title</label>
          <input
            className='form-control'
            type='text'
            id='title'
            name='title'
            value={title}
            onChange={(e) => setTitle(e.target.value)}
          />
        </div>
        <div className='mt-5'>
          <label className='form-label h3'>Record Body</label>
          <input
            className='form-control'
            type='text'
            id='body'
            name='body'
            value={body}
            onChange={(e) => setBody(e.target.value)}
          />
        </div>

        <button type='submit' className='btn btn-success btn-lg w-100 mt-5'>
          Submit
        </button>
        <Link className='btn btn-danger btn-lg w-100 mt-3' to='/'>
          Go Back
        </Link>
      </form>
    </div>
  );
};
export default RecordForm;
