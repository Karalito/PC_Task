const API_BASE_URL = 'https://localhost:7279/';

const ENDPOINTS = {
  GET_ALL_RECORDS: `${API_BASE_URL}get-all-records`,
  GET_RECORD_BY_ID: `${API_BASE_URL}get-record-by-id`,
  CREATE_RECORD: `${API_BASE_URL}create-record`,
  UPDATE_RECORD: `${API_BASE_URL}update-record`,
  DELETE_RECORD_BY_ID: `${API_BASE_URL}delete-record-by-id`,
};

export default ENDPOINTS;