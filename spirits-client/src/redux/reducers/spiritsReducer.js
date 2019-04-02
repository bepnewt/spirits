import * as types from '../actions/spiritsActions';
import initialState from './initialState';

export function spiritsReducer(state = initialState.spirits, action) {
  switch (action.type) {
    case types.LOAD_SPIRITS_SUCCESS:
      return action.spirits;
    default:
      return state;
  }
}
