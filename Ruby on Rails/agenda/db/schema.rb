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

ActiveRecord::Schema.define(version: 20140422181158) do

  create_table "contacts", force: true do |t|
    t.string   "name"
    t.date     "birth"
    t.string   "email"
    t.string   "fone"
    t.string   "address"
    t.text     "obs"
    t.datetime "created_at"
    t.datetime "updated_at"
    t.integer  "user_id"
  end

  create_table "enterprises", force: true do |t|
    t.string   "fantasyname"
    t.string   "address"
    t.string   "fone"
    t.text     "obs"
    t.datetime "created_at"
    t.datetime "updated_at"
    t.integer  "user_id"
  end

  create_table "users", force: true do |t|
    t.string   "fullname"
    t.string   "email"
    t.string   "password"
    t.string   "location"
    t.datetime "created_at"
    t.datetime "updated_at"
  end

end
