import { createStore } from "vuex";

export default createStore({
  state: {
    tasks: null,
  },
  getters: {
    TASKS: (state) => {
      return state.tasks;
    },
  },
  mutations: {
    SET_TASKS: (state, payload) => {
      state.tasks = payload;
    },

    ADD_TASKS: (state, payload) => {
      state.tasks.push(payload);
    },
  },
  actions: {},
  modules: {},
});
