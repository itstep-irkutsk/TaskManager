<template>
  <div class="container">
    <div class="row">
      <div class="col">
        <table class="table">
          <thead>
            <tr>
              <th scope="col">#</th>
              <th scope="col">Title</th>
              <th scope="col">Deadline</th>
              <th scope="col">Status</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="task in tasks" :key="task">
              <th scope="row">{{ task.id }}</th>
              <td>{{ task.title }}</td>
              <td>{{ task.deadline }}</td>
              <td>{{ task.status }}</td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "TasksView",
  computed: {
    tasks() {
      return this.$store.getters.TASKS;
    },
  },
};
</script>

<style scoped></style>
