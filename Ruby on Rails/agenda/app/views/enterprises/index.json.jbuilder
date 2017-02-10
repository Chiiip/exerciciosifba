json.array!(@enterprises) do |enterprise|
  json.extract! enterprise, :id, :fantasyname, :address, :fone, :obs
  json.url enterprise_url(enterprise, format: :json)
end
