json.array!(@admins) do |admin|
  json.extract! admin, :id, :name, :phone, :email, :password
  json.url admin_url(admin, format: :json)
end
