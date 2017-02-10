# encoding: UTF-8
# This file is auto-generated from the current state of the database. Instead
# of editing this file, please use the migrations feature of Active Record to
# incrementally modify your database, and then regenerate this schema definition.
#
# Note that this schema.rb definition is the authoritative source for your
# database schema. If you need to create the application database on another
# system, you should be using db:schema:load, not running all the migrations
# from scratch. The latter is a flawed and unsustainable approach (the more migrations
# you'll amass, the slower it'll run and the greater likelihood for issues).
#
# It's strongly recommended that you check this file into your version control system.

ActiveRecord::Schema.define(version: 20140520032649) do

  create_table "admins", force: true do |t|
    t.string   "name"
    t.string   "phone"
    t.string   "email"
    t.string   "password"
    t.datetime "created_at"
    t.datetime "updated_at"
    t.boolean  "Powers"
    t.boolean  "power",      default: true
  end

  create_table "aluno_turmas", force: true do |t|
    t.integer  "numfaltas"
    t.datetime "created_at"
    t.datetime "updated_at"
    t.integer  "aluno_id"
    t.integer  "curso_id"
    t.integer  "turma_id"
  end

  create_table "alunos", force: true do |t|
    t.string   "name"
    t.string   "phone"
    t.string   "email"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

  create_table "cursos", force: true do |t|
    t.string   "name"
    t.datetime "created_at"
    t.datetime "updated_at"
    t.integer  "admin_id"
    t.integer  "numeroalunos"
  end

  create_table "professors", force: true do |t|
    t.string   "name"
    t.string   "phone"
    t.string   "email"
    t.string   "password"
    t.datetime "created_at"
    t.datetime "updated_at"
    t.boolean  "Powers"
    t.boolean  "power",      default: false
  end

  create_table "turmas", force: true do |t|
    t.string   "name"
    t.datetime "created_at"
    t.datetime "updated_at"
    t.integer  "professor_id"
    t.integer  "numeroalunos"
    t.integer  "curso_id"
  end

end
